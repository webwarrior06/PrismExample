﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace Infrastructure.Events
{
    public class TextChangedEvent:PubSubEvent<string>{}
}
