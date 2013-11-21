﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.AbstractFactory.Xorg
{
    public class Button:AbstractButton
    {
        protected override void OnPaint()
        {
            System.Console.WriteLine("绘制Xorg的button");
            System.Console.WriteLine("开始绘制自定义button");
            base.OnPaint();
            System.Console.WriteLine("结束绘制自定义button");
        }
    }
}
