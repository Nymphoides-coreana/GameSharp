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
