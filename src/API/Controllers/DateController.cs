using Helper.Date;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DateController : ControllerBase
{
    [HttpGet("/current-date-time-utc")]
    public IActionResult GetCurrentDateTimeUtc()
    {
        var currentDateTimeUtc = DateHelper.GetCurrentDateTimeUtc();
        return Ok(currentDateTimeUtc);
    }

    [HttpGet("/current-date-time-utc/{format}")]
    public IActionResult GetCurrentDateTimeUtcWithFormat([FromRoute] string format)
    {
        var currentDateTimeUtc = DateHelper.GetCurrentDateTimeUtc(format);
        return Ok(currentDateTimeUtc);
    }

    [HttpGet("/current-date-time")]
    public IActionResult GetCurrentDateTime()
    {
        var currentDateTime = DateHelper.GetCurrentDateTime();
        return Ok(currentDateTime);
    }

    [HttpGet("/current-date-time/{format}")]
    public IActionResult GetCurrentDateTimeWithFormat([FromRoute] string format)
    {
        var currentDateTime = DateHelper.GetCurrentDateTime(format);
        return Ok(currentDateTime);
    }

    [HttpGet("/previous-date-time-utc/{days}")]
    public IActionResult GetPreviousDateTimeUtc([FromRoute] int days)
    {
        var previousDateTimeUtc = DateHelper.GetPreviousDateTimeUtc(days);
        return Ok(previousDateTimeUtc);
    }

    [HttpGet("/previous-date-time-utc/{days}/{format}")]
    public IActionResult GetPreviousDateTimeUtcWithFormat([FromRoute] int days, [FromRoute] string format)
    {
        var previousDateTimeUtc = DateHelper.GetPreviousDateTimeUtcWithFormat(days, format);
        return Ok(previousDateTimeUtc);
    }

    [HttpGet("/previous-date-time/{days}")]
    public IActionResult GetPreviousDateTime([FromRoute] int days)
    {
        var previousDateTime = DateHelper.GetPreviousDateTime(days);
        return Ok(previousDateTime);
    }

    [HttpGet("/previous-date-time/{days}/{format}")]
    public IActionResult GetPreviousDateTimeWithFormat([FromRoute] int days, [FromRoute] string format)
    {
        var previousDateTime = DateHelper.GetPreviousDateTimeWithFormat(days, format);
        return Ok(previousDateTime);
    }

    [HttpGet("/next-date-time-utc/{days}")]
    public IActionResult GetNextDateTimeUtc([FromRoute] int days)
    {
        var nextDateTimeUtc = DateHelper.GetNextDateTimeUtc(days);
        return Ok(nextDateTimeUtc);
    }

    [HttpGet("/next-date-time-utc/{days}/{format}")]
    public IActionResult GetNextDateTimeUtcWithFormat([FromRoute] int days, [FromRoute] string format)
    {
        var nextDateTimeUtc = DateHelper.GetNextDateTimeUtcWithFormat(days, format);
        return Ok(nextDateTimeUtc);
    }

    [HttpGet("/next-date-time/{days}")]
    public IActionResult GetNextDateTime([FromRoute] int days)
    {
        var nextDateTime = DateHelper.GetNextDateTime(days);
        return Ok(nextDateTime);
    }

    [HttpGet("/next-date-time/{days}/{format}")]
    public IActionResult GetNextDateTimeWithFormat([FromRoute] int days, [FromRoute] string format)
    {
        var nextDateTime = DateHelper.GetNextDateTimeWithFormat(days, format);
        return Ok(nextDateTime);
    }
}