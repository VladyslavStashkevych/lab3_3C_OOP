namespace lab3_3С {
	public class Object {
		static int counter = 0;
		public static int Counter { get => counter; private set => counter = value; }
		protected Object() {
			Counter++;
		}
	}
}
