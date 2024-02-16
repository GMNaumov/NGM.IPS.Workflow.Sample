using System;
using Intermech.Interfaces;
using Intermech.Interfaces.Workflow;

/// <summary>
/// Класс, обязательный к использованию в сценариях Workflow IPS
/// НЕ должен быть статическим
/// </summary>
public class Script
{
    /// <summary>
    /// Обязательное свойство класса Script
    /// ...Напишу, когда узнаю - что это, и для чего нужно
    /// </summary>
    public ICSharpScriptContext ScriptContext { get; set; }

    /// <summary>
    /// Метод, обязательный к использованию в сценариях Workflow IPS
    /// </summary>
    /// <param name="activity"></param>
    public void Execute(IActivity activity)
    {
        // Добавляем новое сообщение к процессу
        // Из приятного - API модуля Workflow почти идентичен API маршрутизатора Search. Ну хоть кто-то о старожилах думает.
        activity.MessageText = "Hello, World!";
    }
}
