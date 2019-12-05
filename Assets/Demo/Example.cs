using UnityEngine;

[DisallowMultipleComponent]
public sealed class Example : MonoBehaviour
{
	// 敵の成長を管理するマスターデータ
	[SerializeField] private EnemyGrowthTable m_enemyGrowthTable = null;

	// マスターデータからレコードを検索する時に使用する
	// 敵の成長 ID と周回数
	[SerializeField] private int m_enemyGrowthId = 0;
	[SerializeField] private int m_lap         = 0;

	private void Start()
	{
		// マスターデータから敵の成長 ID と周回数に紐づくレコードを検索
		var param = m_enemyGrowthTable.param.Find
		(
			c => c.enemyGrowthId == m_enemyGrowthId && c.lap == m_lap
		);

		if ( param == null )
		{
			Debug.Log( "該当するレコードが見つかりませんでした" );
		}
		else
		{
			Debug.Log
			(
				param.enemyGrowthId + ", " +
				param.lap + ", " +
				param.hp + ", " +
				param.attack + "," +
				param.exp
			);
		}
	}
}