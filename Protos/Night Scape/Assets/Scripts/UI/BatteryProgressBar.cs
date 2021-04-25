using UnityEngine;
using UnityEngine.UI;

public class BatteryProgressBar : MonoBehaviour
{
    [SerializeField] private Image fillAmountImage;

    private ManageCar manageCar;
    private void Start()
    {
        manageCar = FindObjectOfType<ManageCar>();
        UpdateProgressBar();
    }

    private void Update()
    {
        UpdateProgressBar();
    }

    private void UpdateProgressBar()
    {
        fillAmountImage.fillAmount = manageCar.GetBatteryPercentage();
    }
}
