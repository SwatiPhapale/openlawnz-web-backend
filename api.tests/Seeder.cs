namespace Tests {
    using api.Entities;
    using System.Collections.Generic;
    class Seeder {
        public static void Seed(BackendContext context)
        {
            AddJoe(context);
            AddMary(context);
        }

        static void AddJoe(BackendContext context)
        {
            var cases = new List<long> { 7215, 9867, 15690, 8238, 23036, 3646, 1181 };
            var folder = new Folder { FolderName = "Economic Disparity" };

            foreach (var c in cases) folder.Cases.Add(new LegalCase { CaseId = c });
            context.Folders.Add(folder);
        }

        static void AddMary(BackendContext context)
        {
            var cases = new List<long> { 3065, 17453, 28690, 7377, 8827, 12792, 12695, 1158, 24803, 2842 };
            var folder = new Folder { FolderName = "Right of way - costs" };

            foreach (var c in cases) folder.Cases.Add(new LegalCase { CaseId = c });
            context.Folders.Add(folder);
        }
    }
}