using Xunit;

namespace Helper.Test.Date;

public class DateHelperTest
{
    [Fact]
    public void GetCurrentDateTimeUtcShouldReturnCurrentDateTimeUtc()
    {
        var expected = DateTime.UtcNow.Date;
        var actual = Helper.Date.DateHelper.GetCurrentDateTimeUtc().Date;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetCurrentDateTimeUtcShouldReturnCurrentDateTimeUtcWithFormat()
    {
        var expected = DateTime.UtcNow;
        var actual = Helper.Date.DateHelper.GetCurrentDateTimeUtc("yyyy-MM-dd");
        Assert.Equal(expected.ToString("yyyy-MM-dd"), actual.ToString("yyyy-MM-dd"));
    }

    [Fact]
    public void GetCurrentDateTimeShouldReturnCurrentDateTime()
    {
        var expected = DateTime.Now.Date;
        var actual = Helper.Date.DateHelper.GetCurrentDateTime().Date;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetCurrentDateTimeShouldReturnCurrentDateTimeWithFormat()
    {
        var expected = DateTime.Now;
        var actual = Helper.Date.DateHelper.GetCurrentDateTime("yyyy-MM-dd");
        Assert.Equal(expected.ToString("yyyy-MM-dd"), actual.ToString("yyyy-MM-dd"));
    }

    [Fact]
    public void GetPreviousDateTimeUtcShouldReturnPreviousDateTimeUtc()
    {
        var expected = DateTime.UtcNow.AddDays(-1).Date;
        var actual = Helper.Date.DateHelper.GetPreviousDateTimeUtc(1).Date;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetPreviousDateTimeUtcShouldReturnPreviousDateTimeUtcWithFormat()
    {
        var expected = DateTime.UtcNow.AddDays(-1);
        var actual = Helper.Date.DateHelper.GetPreviousDateTimeUtcWithFormat(1, "yyyy-MM-dd");
        Assert.Equal(expected.ToString("yyyy-MM-dd"), actual.ToString("yyyy-MM-dd"));
    }

    [Fact]
    public void GetPreviousDateTimeShouldReturnPreviousDateTime()
    {
        var expected = DateTime.Now.AddDays(-1).Date;
        var actual = Helper.Date.DateHelper.GetPreviousDateTime(1).Date;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetPreviousDateTimeShouldReturnPreviousDateTimeWithFormat()
    {
        var expected = DateTime.Now.AddDays(-1);
        var actual = Helper.Date.DateHelper.GetPreviousDateTimeWithFormat(1, "yyyy-MM-dd");
        Assert.Equal(expected.ToString("yyyy-MM-dd"), actual.ToString("yyyy-MM-dd"));
    }

    [Fact]
    public void GetNextDateTimeUtcShouldReturnNextDateTimeUtc()
    {
        var expected = DateTime.UtcNow.AddDays(1).Date;
        var actual = Helper.Date.DateHelper.GetNextDateTimeUtc(1).Date;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetNextDateTimeUtcShouldReturnNextDateTimeUtcWithFormat()
    {
        var expected = DateTime.UtcNow.AddDays(1);
        var actual = Helper.Date.DateHelper.GetNextDateTimeUtcWithFormat(1, "yyyy-MM-dd");
        Assert.Equal(expected.ToString("yyyy-MM-dd"), actual.ToString("yyyy-MM-dd"));
    }

    [Fact]
    public void GetNextDateTimeShouldReturnNextDateTime()
    {
        var expected = DateTime.Now.AddDays(1).Date;
        var actual = Helper.Date.DateHelper.GetNextDateTime(1).Date;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetNextDateTimeShouldReturnNextDateTimeWithFormat()
    {
        var expected = DateTime.Now.AddDays(1);
        var actual = Helper.Date.DateHelper.GetNextDateTimeWithFormat(1, "yyyy-MM-dd");
        Assert.Equal(expected.ToString("yyyy-MM-dd"), actual.ToString("yyyy-MM-dd"));
    }
}