﻿/**
 * Steamless Steam DRM Remover
 * (c) 2015-2016 atom0s [atom0s@live.com]
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see http://www.gnu.org/licenses/
 */

namespace Steamless.Unpackers.Variant3
{
    using Steamless.Classes;

    public class Variant3_0
    {
        /// <summary>
        /// Processes the given file in attempt to remove the DRM protection.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public bool Process(Pe32File file)
        {
            Program.Output("At this time, v3.0.0 is not supported yet.", ConsoleOutputType.Error);
            return false;
        }
    }
}
