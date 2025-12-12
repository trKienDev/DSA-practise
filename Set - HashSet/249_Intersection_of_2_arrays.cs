class Program
{
      static void Main(string[] args)
      {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };

            var result = Intersection(nums1, nums2);

            Console.WriteLine("Intersection result:");
            Console.WriteLine(string.Join(", ", result));
      }

      public static int[] Intersection(int[] nums1, int[] nums2)
      {
            var set1 = new HashSet<int>(nums1);
            var result = new HashSet<int>();

            foreach (var n in nums2)
            {
                  if (set1.Contains(n))
                  result.Add(n);
            }

            return result.ToArray();
      }
}
