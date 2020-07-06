namespace In.ProjectEKA.HipLibrary.Patient.Model
{
    using System.Collections.Generic;

    public class LinkConfirmationRepresentation
    {
        public string ReferenceNumber { get; }

        public string Display { get; }

        public IEnumerable<CareContextRepresentation> CareContexts { get; }

        public LinkConfirmationRepresentation()
        {
        }
        public LinkConfirmationRepresentation(string referenceNumber, string display,
            IEnumerable<CareContextRepresentation> careContexts)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
            CareContexts = careContexts;
        }
    }
}