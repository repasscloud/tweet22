﻿using System;
namespace tweet22.Shared
{
	public class ServiceResponse<T>
	{
		public T Data { get; set; }
		public bool Success { get; set; } = true;
		public string Message { get; set; }
	}
}

