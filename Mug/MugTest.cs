﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Mug
{
    public interface IAdder
    {
        int AddOne(int i);
    }

    public interface IChecker
    {
        void CheckFive(int i);
        void PrintSomething();
    }

    class Subject
    {
        IAdder adder;
        public Subject(IAdder adder)
        {
            this.adder = adder;
        }
        List<int> CountToTen()
        {
            var list = new List<int>();
            int i = 0;
            while (i != 10)
            {
                list.Add(i);
                i = adder.AddOne(i);
            }
            return list;
        }
    }

    [TestFixture]
    class SubjectTest
    {
        //[Test]
        //public void moo()
        //{
        //    var mug = new Mug<IAdder>();

        //    mug.On<int, int>(o => o.AddOne).Do(delegate(int i) { return i + 1; });
        //    var op = mug.Object;
        //    op.AddOne(5);
        //}

        [Test]
        public void moo2()
        {
            var obj = Mug.Mock<IAdder>();

            Mug.On<int, int>(obj.AddOne).Do(delegate(int i) 
            { 
                return i + 2; 
            });

            Assert.That(obj.AddOne(5), Is.EqualTo(7));

            Mug.On<int, int>(obj.AddOne).Do(delegate(int i)
            {
                return i + 3;
            });

            Assert.That(obj.AddOne(5), Is.EqualTo(8));
        }

        [Test]
        public void VoidMethodsWorkToo()
        {
            var obj = Mug.Mock<IChecker>();

            bool wasCalled = false;
            Mug.OnVoid<int>(obj.CheckFive).Do(delegate(int i)
            {
                Assert.That(i, Is.EqualTo(5));
                wasCalled = true;
            });

            obj.CheckFive(5);

            Assert.That(wasCalled);

        }

        [Test]
        public void VoidVoidMethodsWorkToo()
        {
            var obj = Mug.Mock<IChecker>();

            bool wasCalled = false;
            Mug.OnVoid(obj.PrintSomething).Do(delegate()
            {
                wasCalled = true;
            });

            obj.PrintSomething();

            Assert.That(wasCalled);
        }

        [Test]
        public void SimpleSyntaxWorks()
        {
            var obj = Mug.Mock<IAdder>();

            Mug.Stub(obj.AddOne, delegate(int i)
            {
                return i + 1;
            });

            Assert.That(obj.AddOne(5), Is.EqualTo(6));
        }

        [Test, ExpectedException(typeof(MethodNotStubbedException))]
        public void MugShouldThrowOnExecutionOfUnstubbedMethods()
        {
            var obj = Mug.Mock<IAdder>();
            obj.AddOne(5);
        }

        class DummyAdder : IAdder
        {
            public int AddOne(int i) { return i; }
        }

        [Test, ExpectedException(typeof(NotAMugObjectException))]
        public void MugShouldThrowOnStubbingUnMockedObject()
        {
            var obj = new DummyAdder();

            Mug.On<int, int>(obj.AddOne).Do(delegate(int i)
            {
                return i;
            });
        }
    }
}