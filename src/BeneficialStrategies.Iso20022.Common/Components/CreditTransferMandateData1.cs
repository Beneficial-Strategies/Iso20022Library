// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to a credit transfer mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_EVj2MclqEem0vqvvoqYsqQ")]
[DisplayName("Credit Transfer Mandate Data")]
public partial record CreditTransferMandateData1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_EgIuh8lqEem0vqvvoqYsqQ")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    [IsoId("_CLrtsclsEem0vqvvoqYsqQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; } 
    
    /// <summary>
    /// Date on which the credit transfer mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_EgIuiclqEem0vqvvoqYsqQ")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; } 
    
    /// <summary>
    /// Date on which the credit transfer mandate has been verified.
    /// </summary>
    [IsoId("_MBcj0MlqEem0vqvvoqYsqQ")]
    [DisplayName("Date Of Verification")]
    [IsoXmlTag("DtOfVrfctn")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateOfVerification { get; init; } 
    
    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [IsoId("_EgIuj8lqEem0vqvvoqYsqQ")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? ElectronicSignature { get; init; } 
    
    /// <summary>
    /// Date of the first payment of a recurrent credit transfer as per the mandate.
    /// </summary>
    [IsoId("_EgIukclqEem0vqvvoqYsqQ")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstPaymentDate { get; init; } 
    
    /// <summary>
    /// Date of the final payment of a recurrent credit transfer as per the mandate.
    /// </summary>
    [IsoId("_EgIuk8lqEem0vqvvoqYsqQ")]
    [DisplayName("Final Payment Date")]
    [IsoXmlTag("FnlPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalPaymentDate { get; init; } 
    
    /// <summary>
    /// Regularity with which credit transfer instructions are to be created and processed.
    /// </summary>
    [IsoId("_EgIulclqEem0vqvvoqYsqQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency36Choice_? Frequency { get; init; } 
    
    /// <summary>
    /// Reason for the setup of the credit transfer mandate.
    /// Usage: 
    /// The reason will allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_EgIul8lqEem0vqvvoqYsqQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; } 
    
    
    #nullable disable
    
}
