using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class ColorController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ColorController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<ColorDto>>> Get()
    {
        var results = await _unitOfWork.Colors.GetAllAsync();
        return _mapper.Map<List<ColorDto>>(results);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ColorDto>> Get(int id)
    {
        var result = await _unitOfWork.Colors.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return _mapper.Map<ColorDto>(result);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ColorDto>> Post(ColorDto resultDto)
    {
        var result = _mapper.Map<Color>(resultDto);
        _unitOfWork.Colors.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
        {
            return BadRequest();
        }
        resultDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { id = resultDto.Id }, resultDto);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ColorDto>> Put(int id, [FromBody] ColorDto ColorDto)
    {
        var result = await _unitOfWork.Colors.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        if (ColorDto.Id == 0)
        {
            ColorDto.Id = id;
        }
        if (ColorDto.Id != id)
        {
            return BadRequest();
        }
        // Update the properties of the existing entity with values from ColorDto
        _mapper.Map(ColorDto, result);
        // The context is already tracking result, so no need to attach it
        await _unitOfWork.SaveAsync();
        // Return the updated entity
        return _mapper.Map<ColorDto>(result);
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.Colors.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        _unitOfWork.Colors.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
