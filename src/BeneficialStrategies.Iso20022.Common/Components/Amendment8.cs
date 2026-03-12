// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amendment identification.
/// </summary>
[IsoId("_9_mScXltEeG7BsjMvd1mEw_288000024")]
[DisplayName("Amendment")]
public partial record Amendment8
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the issuer to the undertaking, for example the guarantee or standby number.
    /// </summary>
    [IsoId("_9_mScnltEeG7BsjMvd1mEw_1620458309")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Sequence number assigned by the issuer to each amendment of the undertaking.
    /// </summary>
    [IsoId("_9_mSc3ltEeG7BsjMvd1mEw_913627548")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText SequenceNumber { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the beneficiary to the undertaking.
    /// </summary>
    [IsoId("_9_mSdHltEeG7BsjMvd1mEw_2054865214")]
    [DisplayName("Beneficiary Reference Number")]
    [IsoXmlTag("BnfcryRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BeneficiaryReferenceNumber { get; init; } 
    
    /// <summary>
    /// Party that issues the undertaking.
    /// </summary>
    [IsoId("_9_mSdXltEeG7BsjMvd1mEw_634085494")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification43 Issuer { get; init; } 
    
    
    #nullable disable
    
}
