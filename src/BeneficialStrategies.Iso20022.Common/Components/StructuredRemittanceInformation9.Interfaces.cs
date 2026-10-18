// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StructuredRemittanceInformation9 : IStructuredRemittanceInformation9
{
    IEnumerable<IReferredDocumentInformation3> IStructuredRemittanceInformation9.ReferredDocumentInformation => ReferredDocumentInformation;
    IRemittanceAmount2? IStructuredRemittanceInformation9.ReferredDocumentAmount => ReferredDocumentAmount;
    ICreditorReferenceInformation2? IStructuredRemittanceInformation9.CreditorReferenceInformation => CreditorReferenceInformation;
    IPartyIdentification43? IStructuredRemittanceInformation9.Invoicer => Invoicer;
    IPartyIdentification43? IStructuredRemittanceInformation9.Invoicee => Invoicee;
    IEnumerable<string> IStructuredRemittanceInformation9.AdditionalRemittanceInformation => AdditionalRemittanceInformation;
}
