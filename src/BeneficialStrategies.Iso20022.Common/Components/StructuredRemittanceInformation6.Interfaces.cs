// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StructuredRemittanceInformation6 : IStructuredRemittanceInformation6
{
    IReferredDocumentInformation1? IStructuredRemittanceInformation6.ReferredDocumentInformation => ReferredDocumentInformation;
    IEnumerable<IReferredDocumentAmount1Choice> IStructuredRemittanceInformation6.ReferredDocumentAmount => ReferredDocumentAmount;
    ICreditorReferenceInformation1? IStructuredRemittanceInformation6.CreditorReferenceInformation => CreditorReferenceInformation;
    IPartyIdentification8? IStructuredRemittanceInformation6.Invoicer => Invoicer;
    IPartyIdentification8? IStructuredRemittanceInformation6.Invoicee => Invoicee;
}
