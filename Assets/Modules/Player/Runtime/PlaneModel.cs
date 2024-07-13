using UnityEngine;

namespace SitS.Player {
    [CreateAssetMenu]
    sealed class PlaneModel : ScriptableObject {
        [SerializeField]
        internal float dragCoefficient = 1;

        [Space]
        [SerializeField]
        internal float yawSpeed = 1;

        [SerializeField]
        internal float pitchSpeed = 1;

        [SerializeField]
        internal float rollSpeed = 1;

        [Space]
        [SerializeField]
        internal GameObject meshPrefab;
    }
}
