﻿using System.Threading.Tasks;

namespace DiagramAnalysisTest.Interfaces
{
    public interface IDisplay
    {
        /// <summary>
        /// Asynchronously display a list of objects.
        /// </summary>
        /// <param name="obj">The list of objects to display.</param>
        /// <returns><see cref="Task"/></returns>
        ValueTask DisplayAsync(params object[] obj);
    }
}