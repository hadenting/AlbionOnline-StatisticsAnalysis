﻿using log4net;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace StatisticsAnalysisTool.Common;

public static class FileController
{
    private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);

    public static T Load<T>(string localFilePath) where T : new()
    {
        if (!File.Exists(localFilePath))
        {
            return new T();
        }

        try
        {
            var options = new JsonSerializerOptions
            {
                NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowNamedFloatingPointLiterals
            };
            var localFileString = File.ReadAllText(localFilePath, Encoding.UTF8);
            return JsonSerializer.Deserialize<T>(localFileString, options) ?? new T();
        }
        catch (Exception e)
        {
            ConsoleManager.WriteLineForError(MethodBase.GetCurrentMethod()?.DeclaringType, e);
            Log.Error(MethodBase.GetCurrentMethod()?.DeclaringType, e);
            return new T();
        }
    }

    public static void Save<T>(T value, string localFilePath)
    {
        try
        {
            var options = new JsonSerializerOptions
            {
                NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowNamedFloatingPointLiterals
            };
            var fileString = JsonSerializer.Serialize(value, options);
            File.WriteAllText(localFilePath, fileString, Encoding.UTF8);
        }
        catch (Exception e)
        {
            ConsoleManager.WriteLineForError(MethodBase.GetCurrentMethod()?.DeclaringType, e);
            Log.Error(MethodBase.GetCurrentMethod()?.DeclaringType, e);
        }
    }
}