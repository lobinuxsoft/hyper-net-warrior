using UnityEngine;

namespace HNW
{
    [CreateAssetMenu(menuName = "Hyper Net Warrior/Chassis Builder/Chassis Data")]
    public class ChassisData : ScriptableObject
    {
        [SerializeField] int maxHealth;
        [SerializeField] int defense;
        [SerializeField] MeshFilter chassisBody;

        public Chassis BuildChassis(Transform container)
        {
            return new ChassisBuilder()
                .WithName(this.name)
                .WithOwner(container)
                .WithBody(chassisBody)
                .WithMaxHealth(maxHealth)
                .WithDefense(defense)
                .Build();
        }
    }
}