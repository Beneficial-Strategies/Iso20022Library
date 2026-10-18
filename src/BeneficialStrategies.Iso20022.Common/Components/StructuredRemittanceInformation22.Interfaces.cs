// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StructuredRemittanceInformation22 : IStructuredRemittanceInformation22
{
    IEnumerable<IReferredDocumentInformation8> IStructuredRemittanceInformation22.ReferredDocumentInformation => ReferredDocumentInformation;
    IRemittanceAmount4? IStructuredRemittanceInformation22.ReferredDocumentAmount => ReferredDocumentAmount;
    ICreditorReferenceInformation3? IStructuredRemittanceInformation22.CreditorReferenceInformation => CreditorReferenceInformation;
    IPartyIdentification272? IStructuredRemittanceInformation22.Invoicer => Invoicer;
    IPartyIdentification272? IStructuredRemittanceInformation22.Invoicee => Invoicee;
    ITaxData1? IStructuredRemittanceInformation22.TaxRemittance => TaxRemittance;
    IGarnishment4? IStructuredRemittanceInformation22.GarnishmentRemittance => GarnishmentRemittance;
    IEnumerable<ISecuritiesAttributes1> IStructuredRemittanceInformation22.SecuritiesData => SecuritiesData;
    IEnumerable<IsoMax140Text> IStructuredRemittanceInformation22.AdditionalRemittanceInformation => AdditionalRemittanceInformation;
}
