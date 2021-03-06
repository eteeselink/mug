﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Shouldly;
using FakeThat.Extras;

namespace FakeThat.Test
{
    [TestFixture]
    public class PropertyTests
    {
        public void StubbedGetterIsCalledWhenGotten()
        {
            int v = 0;

            var fake = new Fake<IPropertyInterface>();
            var obj = fake.Object;
            var getter = fake.StubGetter(() => obj.GetSet, () => v++);

            obj.GetSet.ShouldBe(0);
            obj.GetSet.ShouldBe(1);
            obj.GetSet.ShouldBe(2);
            obj.GetSet.ShouldBe(3);
            v.ShouldBe(4);

            getter.Count.ShouldBe(4);
            getter.Last().ReturnValue.ShouldBe(3);
        }

        [Test]
        public void StubbedSetterIsCalledWhenSet()
        {
            var fake = new Fake<IPropertyInterface>();
            var obj = fake.Object;

            int latestValue = 0;

            var setterCalls = fake.StubSetter(i => obj.GetSet = i, (int i) => latestValue = i);
            obj.GetSet = 6;

            latestValue.ShouldBe(6);
            setterCalls.Count.ShouldBe(1);
            setterCalls.Single().Value.ShouldBe(6);
        }

        [Test]
        [ExpectedException(typeof(ThatsNotASetterException))]
        public void StubSetterFailsWhenCalled()
        {
            var fake = new Fake<IPropertyInterface>();
            var obj = fake.Object;


            fake.StubSetter(i => { }, (int i) => { });
        }

        [Test]
        public void CanStubSetterWithNullDelegates()
        {
            var fake = new Fake<IPropertyInterface>();
            var setCalls = fake.StubSetter<int>(v => fake.Object.GetSet = v);

            fake.Object.GetSet = 1;
            setCalls.Single().Value.ShouldBe(1);

            var getCalls = fake.StubGetter<int>(() => fake.Object.GetSet);

            var q = fake.Object.GetSet;
            getCalls.Single().ReturnValue.ShouldBe(default(int));
        }
    }
}
