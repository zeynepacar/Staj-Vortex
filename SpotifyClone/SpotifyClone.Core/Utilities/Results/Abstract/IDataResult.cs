﻿using System;
namespace SpotifyClone.Core.Utilities.Results.Abstract
{
	public interface IDataResult<T> : IResult
	{
		T Data { get; }
	}
}

