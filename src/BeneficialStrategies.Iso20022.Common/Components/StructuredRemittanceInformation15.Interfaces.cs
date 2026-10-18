// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StructuredRemittanceInformation15 : IStructuredRemittanceInformation15
{
    IEnumerable<IReferredDocumentInformation7> IStructuredRemittanceInformation15.ReferredDocumentInformation => ReferredDocumentInformation;
    IRemittanceAmount2? IStructuredRemittanceInformation15.ReferredDocumentAmount => ReferredDocumentAmount;
    ICreditorReferenceInformation2? IStructuredRemittanceInformation15.CreditorReferenceInformation => CreditorReferenceInformation;
    IPartyIdentification125? IStructuredRemittanceInformation15.Invoicer => Invoicer;
    IPartyIdentification125? IStructuredRemittanceInformation15.Invoicee => Invoicee;
    ITaxInformation7? IStructuredRemittanceInformation15.TaxRemittance => TaxRemittance;
    IGarnishment2? IStructuredRemittanceInformation15.GarnishmentRemittance => GarnishmentRemittance;
    IEnumerable<string> IStructuredRemittanceInformation15.AdditionalRemittanceInformation => AdditionalRemittanceInformation;
}
