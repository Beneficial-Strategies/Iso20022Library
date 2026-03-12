// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information requested against money laundering for a transfer transaction.
/// </summary>
[IsoId("_jG3qgHs-EeSTS7uHCe8FPQ")]
[DisplayName("Anti Money Laundering")]
public partial record AntiMoneyLaundering1
{
    #nullable enable
    
    /// <summary>
    /// Name of the sender.
    /// </summary>
    [IsoId("_ynk_UHs-EeSTS7uHCe8FPQ")]
    [DisplayName("Sender Name")]
    [IsoXmlTag("SndrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? SenderName { get; init; } 
    
    /// <summary>
    /// Address of the sender.
    /// </summary>
    [IsoId("_36d1QHs-EeSTS7uHCe8FPQ")]
    [DisplayName("Sender Address")]
    [IsoXmlTag("SndrAdr")]
    public PostalAddress18? SenderAddress { get; init; } 
    
    /// <summary>
    /// National identifier number of the sender.
    /// </summary>
    [IsoId("_JJhs0HtAEeSTS7uHCe8FPQ")]
    [DisplayName("Sender National Identifier")]
    [IsoXmlTag("SndrNtlIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SenderNationalIdentifier { get; init; } 
    
    /// <summary>
    /// Country of the national identifier (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_OnaR0HtAEeSTS7uHCe8FPQ")]
    [DisplayName("National Identifier Country")]
    [IsoXmlTag("NtlIdrCtry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? NationalIdentifierCountry { get; init; } 
    
    /// <summary>
    /// Passport number of the sender.
    /// </summary>
    [IsoId("_R-MAYHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Sender Passport Number")]
    [IsoXmlTag("SndrPsptNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SenderPassportNumber { get; init; } 
    
    /// <summary>
    /// Country issuing the passport (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_VDe9YHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Passport Issuing Country")]
    [IsoXmlTag("PsptIssgCtry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? PassportIssuingCountry { get; init; } 
    
    /// <summary>
    /// Tax identifier of the sender.
    /// </summary>
    [IsoId("_bkH_4HtAEeSTS7uHCe8FPQ")]
    [DisplayName("Sender Tax Identifier")]
    [IsoXmlTag("SndrTaxIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SenderTaxIdentifier { get; init; } 
    
    /// <summary>
    /// Country of the tax (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_fQduwHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Tax Country")]
    [IsoXmlTag("TaxCtry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? TaxCountry { get; init; } 
    
    /// <summary>
    /// Customer identifier of the sender.
    /// </summary>
    [IsoId("_nfe-oHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Sender Customer Identifier")]
    [IsoXmlTag("SndrCstmrIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SenderCustomerIdentifier { get; init; } 
    
    /// <summary>
    /// Date and place of birth of the sender.
    /// </summary>
    [IsoId("_s2m0UHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Sender Date And Place Of Birth")]
    [IsoXmlTag("SndrDtAndPlcOfBirth")]
    public DateAndPlaceOfBirth? SenderDateAndPlaceOfBirth { get; init; } 
    
    /// <summary>
    /// Name of the receiver.
    /// </summary>
    [IsoId("_xrSrUHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Receiver Name")]
    [IsoXmlTag("RcvrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ReceiverName { get; init; } 
    
    /// <summary>
    /// Unique transaction reference number for sender and the receiver.
    /// </summary>
    [IsoId("_4Q5GUHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Transaction Reference")]
    [IsoXmlTag("TxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TransactionReference { get; init; } 
    
    
    #nullable disable
    
}
