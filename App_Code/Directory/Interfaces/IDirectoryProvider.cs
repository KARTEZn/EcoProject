using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для IDirectoryProvider
/// </summary>
public interface IDirectoryProvider
{
    /// <summary>
    /// Наименование провайдера (уникальное)
    /// </summary>
    string ProviderName { get; set; }

    /// <summary>
    /// Сохранить данные
    /// </summary>
    void SaveData();

    /// <summary>
    /// Очистить данные
    /// </summary>
    void ClearData();
}