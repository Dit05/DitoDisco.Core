namespace DitoDisco.Core.Tests;

[TestOf(typeof(IGenericEnumerable<>))]
public class Tests {

    class CustomEnumerator : IEnumerator<int> {
        public int Current => throw new NotImplementedException();
        object System.Collections.IEnumerator.Current => throw new NotImplementedException();
        public void Dispose() => throw new NotImplementedException();
        public bool MoveNext() => throw new NotImplementedException();
        public void Reset() => throw new NotImplementedException();
    }

    class CustomGenericEnumerable : IGenericEnumerable<int> {

        public readonly CustomEnumerator enumerator = new CustomEnumerator();

        public IEnumerator<int> GetEnumerator() => enumerator;
    }


    CustomGenericEnumerable enumerable = new CustomGenericEnumerable();


    [Test]
    public void SamenessTest() {
        Assert.That(enumerable.GetEnumerator(), Is.SameAs(enumerable.enumerator));
        Assert.That((enumerable as IEnumerable<int>).GetEnumerator(), Is.SameAs(enumerable.enumerator));
        Assert.That((enumerable as System.Collections.IEnumerable).GetEnumerator(), Is.SameAs(enumerable.enumerator));
    }

}
