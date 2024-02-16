using System;
using System.Text;
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
        int attachmentsCount = activity.Attachments.Count;

        if (attachmentsCount == 0)
        {
            activity.MessageText = "Отсутствуют объекты во вложениях процесса!"
        }
        else
        {
            StringBuilder sb = new StringBuilder();
            string prefix = $"Количество объектов во вложениях процесса: {attachmentsCount}";

            sb.Append(prefix);

            for (int i = 0; i < attachmentsCount; i++)
            {
                
            }
        }
    }
}
