using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для IDirectory (интерфейс справочника)
/// </summary>
public interface IDirectory
{
    /// <summary>
    /// Наименование справочника
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Число заголовков (столбцов)
    /// </summary>
    int HeaderCount { get; }

    /// <summary>
    /// Определяет провайдера (место хранения данных: база, файл, иные форматы)
    /// </summary>
    IDirectoryProvider Provider { get; set; }

    /// <summary>
    /// Метод позволяющий добавить заголовок (столбец)
    /// </summary>
    /// <param name="value">наименование заголовка (столбца)</param>
    void AddHeader(string value);

    /// <summary>
    /// Добавляем заголовок после уже существующего
    /// </summary>
    /// <param name="value">Наименование нового заголовка</param>
    /// <param name="prev">Наименование существующего заголовка</param>
    void AddHeaderAfter(string value, string prev);

    /// <summary>
    /// Метод позволяющий изъять заголовок (столбец)
    /// </summary>
    /// <param name="value"></param>
    void RemoveHeader(string value);

    /// <summary>
    /// Метод позволяющий удалить справочник
    /// </summary>
    void DropHeaders();
}