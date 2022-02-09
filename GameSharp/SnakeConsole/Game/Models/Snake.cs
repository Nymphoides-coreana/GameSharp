//    Copyright (C) <2022>  <小莕菜>
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsole.Game.Models
{
    internal class Snake
    {
        private List<SnakeBody> SnakeBodies { get; }
        internal Snake()
        {
            SnakeBodies = new List<SnakeBody>()
            {
                new SnakeBody(SnakeBodyType.Head),
                new SnakeBody(SnakeBodyType.Body),
                new SnakeBody(SnakeBodyType.Body),
                new SnakeBody(SnakeBodyType.Body),
            };
        }
    }

    internal class SnakeBody
    {
        private SnakeBodyType BodyType { get; }
        internal SnakeBody(SnakeBodyType bodyType)
        {
            BodyType = bodyType;
        }

        internal void BodyPrint()
        {
            switch (BodyType)
            {
                case SnakeBodyType.Body:
                    Console.Write("o");
                    break;
                case SnakeBodyType.Head:
                    Console.Write("O");
                    break;
                default:
                    break;
            }
        }
    }

    internal enum SnakeBodyType
    {
        /// <summary>
        /// 身体
        /// </summary>
        Body,
        /// <summary>
        /// 头
        /// </summary>
        Head,
    }
}
