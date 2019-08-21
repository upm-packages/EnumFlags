using UnityEngine;

namespace EnumFlags.Tests.Runtime
{
    public class SampleComponent : MonoBehaviour
    {
        [SerializeField][EnumFlags] private SampleFlag sampleFlag = default;

        public SampleFlag SampleFlag => sampleFlag;
    }
}

