// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StructuredRemittanceInformation12 : IStructuredRemittanceInformation12
{
    IEnumerable<IReferredDocumentInformation6> IStructuredRemittanceInformation12.ReferredDocumentInformation => ReferredDocumentInformation;
    IRemittanceAmount2? IStructuredRemittanceInformation12.ReferredDocumentAmount => ReferredDocumentAmount;
    ICreditorReferenceInformation2? IStructuredRemittanceInformation12.CreditorReferenceInformation => CreditorReferenceInformation;
    IPartyIdentification43? IStructuredRemittanceInformation12.Invoicer => Invoicer;
    IPartyIdentification43? IStructuredRemittanceInformation12.Invoicee => Invoicee;
    ITaxInformation4? IStructuredRemittanceInformation12.TaxRemittance => TaxRemittance;
    IGarnishment1? IStructuredRemittanceInformation12.GarnishmentRemittance => GarnishmentRemittance;
    IEnumerable<string> IStructuredRemittanceInformation12.AdditionalRemittanceInformation => AdditionalRemittanceInformation;
}
