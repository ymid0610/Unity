using UnityEngine;

public class MouseDown : MonoBehaviour
{
    public GameObject prefab;

    public float force = 5.0f;

    // 유니티 에디터에서 퍼지는 범위를 조절할 수 있습니다.
    public float spreadSize = 1f; 

    private void OnMouseDown()
    {
        if (prefab != null)
        {
            for (int i = 0; i < 100; i++)
            {
                // 반경 1짜리 구(공) 형태 안에서 무작위 위치를 뽑아줍니다.
                Vector3 randomOffset = Random.insideUnitSphere * spreadSize;

                // 현재 오브젝트 위치를 중심으로 사방으로 퍼진 위치 계산
                Vector3 spawnPosition = transform.position + randomOffset;

                Quaternion spawnRotation = Random.rotation;

                GameObject obj = GameObject.Instantiate(prefab, spawnPosition, spawnRotation);
                Rigidbody rigidbody = obj.GetComponent<Rigidbody>();
                rigidbody.AddRelativeForce(Random.onUnitSphere * force, ForceMode.Force);

                obj.GetComponent<Renderer>().material.color = Random.ColorHSV();

                GameObject.Destroy(obj, 2f);
            }
        }

        Destroy(gameObject); 
    }
}
