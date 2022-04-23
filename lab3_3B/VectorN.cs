namespace lab3_3С {
	public class VectorN : Object {
		int n;
		double[] a;

		public int N {
			get => n;
			set {
				if (value >= 0) {
					n = value;
					A = new double[n];
				}
			}
		}
		public double[] A { get => a; set => a = value; }

		public VectorN() {
			this.N = 0;
			this.A = Array.Empty<double>();
		}
		public VectorN(int n, double[] a) {
			this.N = n;
			for(int i = 0; i< N; i++) {
				this.A[i] = a[i];
			}
		}
		public VectorN(VectorN v) {
			this.N = v.N;
			for(int i = 0; i< N; i++) {
				this.A[i] = v.A[i];
			}
		}

		public VectorN Add(VectorN v) => this + v;
		public VectorN Substract(VectorN v) => this - v;
		public double Scalar(VectorN v) => this * v;

		public static VectorN operator + (VectorN v1, VectorN v2) {
			VectorN result = new VectorN();
			if (v1.N != v2.N) {
				Console.WriteLine("Vectors should have same size");
				return result;
			}
			result.N = v1.N;
			for (int i = 0; i < v1.N; i++) {
				result.A[i] = v1.A[i] + v2.A[i];
			}
			return result;
		}
		public static VectorN operator - (VectorN v1, VectorN v2) {
			VectorN result = new VectorN();
			if (v1.N != v2.N) {
				Console.WriteLine("Vectors should have same size");
				return result;
			}
			result.N = v1.N;
			for (int i = 0; i < v1.N; i++) {
				result.A[i] = v1.A[i] - v2.A[i];
			}
			return result;
		}
		public static double operator * (VectorN v1, VectorN v2) {
			double result = 0;
			if (v1.N != v2.N) {
				Console.WriteLine("Vectors should have same size");
				return result;
			}
			for (int i = 0; i < v1.N; i++) {
				result += v1.A[i] * v2.A[i];
			}
			return result;
		}

		public VectorN PostIncrement() {
			VectorN vres = new VectorN(this.N, this.A);
			for(int i = 0; i < N; i++) {
				this.A[i]++;
			}
			return vres;
		}
		public static VectorN operator ++ (VectorN v){
			for (int i = 0; i < v.N; i++) {
				v.A[i]++;
			}
			return v;
		}
		public VectorN PostDecrement() {
			VectorN vres = new VectorN(this.N, this.A);
			for(int i = 0; i < N; i++) {
				this.A[i]--;
			}
			return vres;
		}
		public static VectorN operator -- (VectorN v) {
			for (int i = 0; i < v.N; i++) {
				v.A[i]--;
			}
			return v;
		}

		public void Read() {
			bool initExecuted = false;
			do {
				Console.Write("Enter number of elements: ");
				int num = Convert.ToInt32(Console.ReadLine());
				if (num < 0) {
					Console.WriteLine("Number of elements should be greater than zero!");
					Console.WriteLine("Please, try again");
				}
				else {
					double[] arr = new double[num];
					for (int i = 0; i < num; i++) {
						Console.Write($"Enter numnber {i + 1}: ");
						arr[i] = Convert.ToDouble(Console.ReadLine());
					}
					Console.WriteLine();
					this.N = num;
					this.A = arr;
					initExecuted = true;
				}
			} while (!initExecuted);
		}
		public void Display() {
			Console.WriteLine(this.ToString());
		}
		public override string ToString()
				=> String.Join(" ", A.Select(c => $"{c}"));
	}
}
