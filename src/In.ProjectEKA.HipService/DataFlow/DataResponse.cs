namespace In.ProjectEKA.HipService.DataFlow
{
    using System.Collections.Generic;

    public class DataResponse
    {
        public DataResponse(string transactionId, IEnumerable<Entry> entries)
        {
            TransactionId = transactionId;
            Entries = entries;
        }

        public string TransactionId { get; }

        public IEnumerable<Entry> Entries { get; }
    }
}