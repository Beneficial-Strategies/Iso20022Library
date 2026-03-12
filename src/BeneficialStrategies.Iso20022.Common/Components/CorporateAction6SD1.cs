// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension for mergers.
/// </summary>
[IsoId("_yeONwFPNEeG1_c7AazzqRQ")]
[DisplayName("Corporate Action 6 SD")]
public partial record CorporateAction6SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_9xiVEFPNEeG1_c7AazzqRQ")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Provides additional information about mergers.
    /// </summary>
    [IsoId("_Cmb7kFPbEeG1qPPaW9KJvg")]
    [DisplayName("Merger Details")]
    [IsoXmlTag("MrgrDtls")]
    public MergerDetailsType1? MergerDetails { get; init; } 
    
    /// <summary>
    /// Agreement of the target company.
    /// TargetCompanyAgreement should only be used for corporate action event type code TEND. It is not necessary for corporate action event type code BIDS. 
    ///  対象会社の同意の有無
    /// 公開買付のときのみ。（自己株買付のときは無し）.
    /// </summary>
    [IsoId("_Glt4hWzdEeGa9q9Mq4E7uA")]
    [DisplayName("Target Company Agreement")]
    [IsoXmlTag("TrgtCpnyAgrmt")]
    public TargetCompanyAgreementCode? TargetCompanyAgreement { get; init; } 
    
    /// <summary>
    /// Total number of new shares to be issued.
    /// 発行新株式数.
    /// </summary>
    [IsoId("_KOn45WzdEeGa9q9Mq4E7uA")]
    [DisplayName("Total Number Of New Shares Issued")]
    [IsoXmlTag("TtlNbOfNewShrsIssd")]
    public FinancialInstrumentQuantity15Choice_? TotalNumberOfNewSharesIssued { get; init; } 
    
    
    #nullable disable
    
}
