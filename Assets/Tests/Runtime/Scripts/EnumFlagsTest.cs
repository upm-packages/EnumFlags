using System.Collections;
using System.Linq;
using NUnit.Framework;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace EnumFlags.Tests.Runtime
{
    public class EnumFlagsTest
    {
        [UnityTest]
        public IEnumerator Test()
        {
            var loadSceneAsyncOperator = SceneManager.LoadSceneAsync("Sample", LoadSceneMode.Additive);
            while (!loadSceneAsyncOperator.isDone)
            {
                yield return null;
            }

            var scene = SceneManager.GetSceneByName("Sample");
            var component = scene.GetRootGameObjects().FirstOrDefault(x => x.GetComponent<SampleComponent>() != null)?.GetComponent<SampleComponent>();
            Assert.NotNull(component);
            Assert.True(component.SampleFlag.HasFlag(SampleFlag.Foo));
            Assert.False(component.SampleFlag.HasFlag(SampleFlag.Bar));
            Assert.True(component.SampleFlag == (SampleFlag.Foo | SampleFlag.Buz));
        }
    }
}