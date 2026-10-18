// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StructuredRemittanceInformation16 : IStructuredRemittanceInformation16
{
    IEnumerable<IReferredDocumentInformation7> IStructuredRemittanceInformation16.ReferredDocumentInformation => ReferredDocumentInformation;
    IRemittanceAmount2? IStructuredRemittanceInformation16.ReferredDocumentAmount => ReferredDocumentAmount;
    ICreditorReferenceInformation2? IStructuredRemittanceInformation16.CreditorReferenceInformation => CreditorReferenceInformation;
    IPartyIdentification135? IStructuredRemittanceInformation16.Invoicer => Invoicer;
    IPartyIdentification135? IStructuredRemittanceInformation16.Invoicee => Invoicee;
    ITaxInformation7? IStructuredRemittanceInformation16.TaxRemittance => TaxRemittance;
    IGarnishment3? IStructuredRemittanceInformation16.GarnishmentRemittance => GarnishmentRemittance;
    IEnumerable<string> IStructuredRemittanceInformation16.AdditionalRemittanceInformation => AdditionalRemittanceInformation;
}
