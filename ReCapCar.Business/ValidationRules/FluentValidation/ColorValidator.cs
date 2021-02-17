using FluentValidation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ReCapCar.Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {

        }
    }
}
