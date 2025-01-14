using UnityEngine;

namespace Sits.Collectibles {
    sealed class CollectibleCollector : MonoBehaviour {
        [SerializeField]
        SitS.Player.PlayerModel playerModel;

        void OnEnable() {
            playerModel.collectiblesCollected = 0;
        }

        public void Collect(uint amount) {
            playerModel.collectiblesCollected += amount;
        }
    }
}
