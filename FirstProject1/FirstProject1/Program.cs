﻿// 파란글자:
// 키워드(예약어)란? 미리 정의되어있는 단어
// 이미 문법용도로 사용되고있기때문에 식별용으로 개발자가 쓸 수 없다.
//
// 흰글자:
// 식별문자 (참조있음)
//
// 어두운 글자라면:
// 식별문자 (참조없음/ 생략가능 == 암시적표현)
//
// 청록색 글자:
// 클래스타입 이름
//
// 노란색글자:
// 함수 이름
//
// 하늘색글자:
// 함수의 파라미터 (매개변수)의 식별문자 (이름)
//
// 주황색글자:
// 문자/ 문자열 상수

// using 키워드 
// 특정 namespace를 사용하기위한 키워드
// 형식: using namespace 이름
using System;

// namespace 키워드
// 공간을 구분하기 위한 키워드
// (내부 식별자를 가지고 namespace로 묶인 변수, 함수, 클래스, 인터페이스 등등을 구분함)
namespace FirstProject1 // Note: actual namespace depends on the project name.
{
    // internal 키워드
    // 동일 어셈블리에서만 접근가능한 키워드

    // class 키워드
    // 객체를 만들기위한 타입을 정의하는 키워드
    // 형식: class 클래스이름
    internal class Program
    {
        // static 키워드
        // 정적 키워드, 메모리에 동적할당이 불가능한 속성을 부여함.

        // void키워드
        // 아무것도 없음.(반환값이 없음)

        // Mian 함수
        // 실행파일 (.exe)을 실행했을 때 가장먼저 실행되는 함수
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }
    }
}