// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StructuredRemittanceInformation18 : IStructuredRemittanceInformation18
{
    IEnumerable<IsoMax140Text> IStructuredRemittanceInformation18.AdditionalRemittanceInformation => AdditionalRemittanceInformation;
    ICreditorReferenceInformation3? IStructuredRemittanceInformation18.CreditorReferenceInformation => CreditorReferenceInformation;
    IGarnishment4? IStructuredRemittanceInformation18.GarnishmentRemittance => GarnishmentRemittance;
    IPartyIdentification272? IStructuredRemittanceInformation18.Invoicee => Invoicee;
    IPartyIdentification272? IStructuredRemittanceInformation18.Invoicer => Invoicer;
    IRemittanceAmount4? IStructuredRemittanceInformation18.ReferredDocumentAmount => ReferredDocumentAmount;
    IEnumerable<IReferredDocumentInformation8> IStructuredRemittanceInformation18.ReferredDocumentInformation => ReferredDocumentInformation;
    ITaxData1? IStructuredRemittanceInformation18.TaxRemittance => TaxRemittance;
}
