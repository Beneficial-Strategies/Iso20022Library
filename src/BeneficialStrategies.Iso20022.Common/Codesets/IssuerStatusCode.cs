// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) defined issuer status of the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1nV48zL3EeKU9IrkkToqcw_1768517900")]
[Description(@"Specifies DTC (The Depository Trust Company) defined issuer status of the event.")]
[Derivations(typeof(IssuerStatus1Code))]
public enum IssuerStatusCode
{
    /// <summary>
    /// Event is approved by SEC (Securities and Exchange Commission).
    /// Encoded/decoded by serializers as &quot;ASEC&quot;.
    /// </summary>
    [EnumMember(Value = "ASEC")]
    [IsoId("_1nV49DL3EeKU9IrkkToqcw_-588924573")]
    [Description(@"Event is approved by SEC (Securities and Exchange Commission).")]
    ApprovedBySEC,
    
    /// <summary>
    /// Event is approved by shareholders.
    /// Encoded/decoded by serializers as &quot;ASHH&quot;.
    /// </summary>
    [EnumMember(Value = "ASHH")]
    [IsoId("_1nV49TL3EeKU9IrkkToqcw_1995060814")]
    [Description(@"Event is approved by shareholders.")]
    ApprovedByShareholders,
    
    /// <summary>
    /// Event is approved by SEC (Securities and Exchange Commission and shareholders.
    /// Encoded/decoded by serializers as &quot;ASHS&quot;.
    /// </summary>
    [EnumMember(Value = "ASHS")]
    [IsoId("_1nV49jL3EeKU9IrkkToqcw_1933446282")]
    [Description(@"Event is approved by SEC (Securities and Exchange Commission and shareholders.")]
    ApprovedByShareholdersAndSEC,
    
    /// <summary>
    /// Event has approximate rate.
    /// Encoded/decoded by serializers as &quot;APRT&quot;.
    /// </summary>
    [EnumMember(Value = "APRT")]
    [IsoId("_1nfC4DL3EeKU9IrkkToqcw_1387036780")]
    [Description(@"Event has approximate rate.")]
    ApproximateRate,
    
    /// <summary>
    /// Awaiting information from company on the event.
    /// Encoded/decoded by serializers as &quot;AIFC&quot;.
    /// </summary>
    [EnumMember(Value = "AIFC")]
    [IsoId("_1nfC4TL3EeKU9IrkkToqcw_1626850307")]
    [Description(@"Awaiting information from company on the event.")]
    AwaitingInformationFromCompany,
    
    /// <summary>
    /// Event has day grace period.
    /// Encoded/decoded by serializers as &quot;DGRP&quot;.
    /// </summary>
    [EnumMember(Value = "DGRP")]
    [IsoId("_1nfC4jL3EeKU9IrkkToqcw_2014788257")]
    [Description(@"Event has day grace period.")]
    DayGracePeriod,
    
    /// <summary>
    /// Event distribution was rejected.
    /// Encoded/decoded by serializers as &quot;DREJ&quot;.
    /// </summary>
    [EnumMember(Value = "DREJ")]
    [IsoId("_1nfC4zL3EeKU9IrkkToqcw_-922709630")]
    [Description(@"Event distribution was rejected.")]
    DistributionRejected,
    
    /// <summary>
    /// Event has free form comments for review.
    /// Encoded/decoded by serializers as &quot;FFCO&quot;.
    /// </summary>
    [EnumMember(Value = "FFCO")]
    [IsoId("_1nfC5DL3EeKU9IrkkToqcw_-1721580482")]
    [Description(@"Event has free form comments for review.")]
    SeeComments,
    
    /// <summary>
    /// Holiday in country of origin of the event.
    /// Encoded/decoded by serializers as &quot;HOCO&quot;.
    /// </summary>
    [EnumMember(Value = "HOCO")]
    [IsoId("_1nfC5TL3EeKU9IrkkToqcw_-1974314621")]
    [Description(@"Holiday in country of origin of the event.")]
    HolidayInCountryofOrigin,
    
    /// <summary>
    /// Event issue is not funded.
    /// Encoded/decoded by serializers as &quot;INFN&quot;.
    /// </summary>
    [EnumMember(Value = "INFN")]
    [IsoId("_1nfC5jL3EeKU9IrkkToqcw_-1177701568")]
    [Description(@"Event issue is not funded.")]
    IssueNotFunded,
    
    /// <summary>
    /// Event issue is trading flat.
    /// Encoded/decoded by serializers as &quot;ITFL&quot;.
    /// </summary>
    [EnumMember(Value = "ITFL")]
    [IsoId("_1noz4DL3EeKU9IrkkToqcw_1960432866")]
    [Description(@"Event issue is trading flat.")]
    IssueTradingFlat,
    
    /// <summary>
    /// Event is a late announcement with elections.
    /// Encoded/decoded by serializers as &quot;LAWE&quot;.
    /// </summary>
    [EnumMember(Value = "LAWE")]
    [IsoId("_1noz4TL3EeKU9IrkkToqcw_-500138118")]
    [Description(@"Event is a late announcement with elections.")]
    LateAnnouncementWithElections,
    
    /// <summary>
    /// Event is a liquidation.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_1noz4jL3EeKU9IrkkToqcw_-386645654")]
    [Description(@"Event is a liquidation.")]
    Liquidation,
    
    /// <summary>
    /// Event proceeds will be paid upon receipt of funds.
    /// Encoded/decoded by serializers as &quot;PURF&quot;.
    /// </summary>
    [EnumMember(Value = "PURF")]
    [IsoId("_1noz4zL3EeKU9IrkkToqcw_-711556448")]
    [Description(@"Event proceeds will be paid upon receipt of funds.")]
    PaidUponrReceiptOfFunds,
    
    /// <summary>
    /// Event processed are pending conversion of funds.
    /// Encoded/decoded by serializers as &quot;PCOF&quot;.
    /// </summary>
    [EnumMember(Value = "PCOF")]
    [IsoId("_1noz5DL3EeKU9IrkkToqcw_874900296")]
    [Description(@"Event processed are pending conversion of funds.")]
    PendingConversionOfFunds,
    
    /// <summary>
    /// Event is pending election dividend services elections.
    /// Encoded/decoded by serializers as &quot;PELE&quot;.
    /// </summary>
    [EnumMember(Value = "PELE")]
    [IsoId("_1noz5TL3EeKU9IrkkToqcw_950608066")]
    [Description(@"Event is pending election dividend services elections.")]
    PendingEDSElections,
    
    /// <summary>
    /// Event is pending SEC (Securities and Exchange Commission approval.
    /// Encoded/decoded by serializers as &quot;PSEC&quot;.
    /// </summary>
    [EnumMember(Value = "PSEC")]
    [IsoId("_1noz5jL3EeKU9IrkkToqcw_1788135108")]
    [Description(@"Event is pending SEC (Securities and Exchange Commission approval.")]
    PendingSECApproval,
    
    /// <summary>
    /// Event is pending SEC (Securities and Exchange Commission and shareholders approval.
    /// Encoded/decoded by serializers as &quot;PSHS&quot;.
    /// </summary>
    [EnumMember(Value = "PSHS")]
    [IsoId("_1nx90DL3EeKU9IrkkToqcw_-1876785616")]
    [Description(@"Event is pending SEC (Securities and Exchange Commission and shareholders approval.")]
    PendingShareholderAndSECApproval,
    
    /// <summary>
    /// Event is pending shareholder approval.
    /// Encoded/decoded by serializers as &quot;PSHA&quot;.
    /// </summary>
    [EnumMember(Value = "PSHA")]
    [IsoId("_1nx90TL3EeKU9IrkkToqcw_1260953691")]
    [Description(@"Event is pending shareholder approval.")]
    PendingShareholderApproval,
    
}
