﻿using System;
using System.Runtime.CompilerServices;

//? 확인함.
//? 질문 : 1개
//? 확인 필요 : 0개

//* 상태를 감지하는 역할을 하는 스크립트.
public interface IStateHandler<T> : IEquatable<T>
where T : new()
{
    T Handle { get; set; }

    //! 질문 : other가 어디서 나온지 잘 모르겠습니다.
    bool IEquatable<T>.Equals(T other)
    {
        return Handle.Equals(other);
    }
}