using UnityEngine;
namespace BehaviorDesigner.Runtime.Tasks
{
	[TaskIcon("Assets/Png/{SkinColor}Nuclear.png")]
	[TaskCategory("Test")]
	public class TestTask : Action
	{
		public SharedString text;
		public override TaskStatus OnUpdate()
		{
			Debug.Log(text);
			return TaskStatus.Success;
		}
	}
}

