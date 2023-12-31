﻿using Helper.Logging.Model;
using Newtonsoft.Json;

namespace Helper.Logging;

public class LogModelCreatorService : ILogModelCreatorService
{
    public LogModel LogModel { get; private set; }

    public LogModelCreatorService()
    {
        LogModel = new LogModel();
    }

    public string ConvertToString()
    {
        var jsonString = JsonConvert.SerializeObject(LogModel);
        return jsonString;
    }
}