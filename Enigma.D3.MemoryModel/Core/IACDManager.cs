﻿using Enigma.D3.MemoryModel.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
	public interface IACDManager
	{
		IContainer<IACD> ActorCommonData { get; }
	}
}