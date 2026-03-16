// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) defined issuer status of the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1ss6EDL3EeKU9IrkkToqcw_857646177")]
[Description(@"Specifies DTC (The Depository Trust Company) defined issuer status of the event.")]
[DerivedFrom(typeof(IssuerStatusCode))]
public enum IssuerStatus1Code
{
    /// <summary>
    /// Event is approved by SEC (Securities and Exchange Commission).
    /// Encoded/decoded by serializers as &quot;ASEC&quot;.
    /// </summary>
    [EnumMember(Value = "ASEC")]
    [IsoId("_1ss6ETL3EeKU9IrkkToqcw_549706816")]
    [Description(@"Event is approved by SEC (Securities and Exchange Commission).")]
    ApprovedBySEC = IssuerStatusCode.ApprovedBySEC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is approved by shareholders.
    /// Encoded/decoded by serializers as &quot;ASHH&quot;.
    /// </summary>
    [EnumMember(Value = "ASHH")]
    [IsoId("_1ss6EjL3EeKU9IrkkToqcw_435867750")]
    [Description(@"Event is approved by shareholders.")]
    ApprovedByShareholders = IssuerStatusCode.ApprovedByShareholders, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is approved by SEC (Securities and Exchange Commission and shareholders.
    /// Encoded/decoded by serializers as &quot;ASHS&quot;.
    /// </summary>
    [EnumMember(Value = "ASHS")]
    [IsoId("_1ss6EzL3EeKU9IrkkToqcw_1003794085")]
    [Description(@"Event is approved by SEC (Securities and Exchange Commission and shareholders.")]
    ApprovedByShareholdersAndSEC = IssuerStatusCode.ApprovedByShareholdersAndSEC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event has approximate rate.
    /// Encoded/decoded by serializers as &quot;APRT&quot;.
    /// </summary>
    [EnumMember(Value = "APRT")]
    [IsoId("_1ss6FDL3EeKU9IrkkToqcw_1328911592")]
    [Description(@"Event has approximate rate.")]
    ApproximateRate = IssuerStatusCode.ApproximateRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting information from company on the event.
    /// Encoded/decoded by serializers as &quot;AIFC&quot;.
    /// </summary>
    [EnumMember(Value = "AIFC")]
    [IsoId("_1ss6FTL3EeKU9IrkkToqcw_1215072526")]
    [Description(@"Awaiting information from company on the event.")]
    AwaitingInformationFromCompany = IssuerStatusCode.AwaitingInformationFromCompany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event has day grace period.
    /// Encoded/decoded by serializers as &quot;DGRP&quot;.
    /// </summary>
    [EnumMember(Value = "DGRP")]
    [IsoId("_1s2rEDL3EeKU9IrkkToqcw_-1006162773")]
    [Description(@"Event has day grace period.")]
    DayGracePeriod = IssuerStatusCode.DayGracePeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event distribution was rejected.
    /// Encoded/decoded by serializers as &quot;DREJ&quot;.
    /// </summary>
    [EnumMember(Value = "DREJ")]
    [IsoId("_1s2rETL3EeKU9IrkkToqcw_-681045266")]
    [Description(@"Event distribution was rejected.")]
    DistributionRejected = IssuerStatusCode.DistributionRejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event has free form comments for review.
    /// Encoded/decoded by serializers as &quot;FFCO&quot;.
    /// </summary>
    [EnumMember(Value = "FFCO")]
    [IsoId("_1s2rEjL3EeKU9IrkkToqcw_-794884332")]
    [Description(@"Event has free form comments for review.")]
    SeeComments = IssuerStatusCode.SeeComments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holiday in country of origin of the event.
    /// Encoded/decoded by serializers as &quot;HOCO&quot;.
    /// </summary>
    [EnumMember(Value = "HOCO")]
    [IsoId("_1s2rEzL3EeKU9IrkkToqcw_396975072")]
    [Description(@"Holiday in country of origin of the event.")]
    HolidayInCountryofOrigin = IssuerStatusCode.HolidayInCountryofOrigin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event issue is not funded.
    /// Encoded/decoded by serializers as &quot;INFN&quot;.
    /// </summary>
    [EnumMember(Value = "INFN")]
    [IsoId("_1s2rFDL3EeKU9IrkkToqcw_283136006")]
    [Description(@"Event issue is not funded.")]
    IssueNotFunded = IssuerStatusCode.IssueNotFunded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event issue is trading flat.
    /// Encoded/decoded by serializers as &quot;ITFL&quot;.
    /// </summary>
    [EnumMember(Value = "ITFL")]
    [IsoId("_1s2rFTL3EeKU9IrkkToqcw_1448108144")]
    [Description(@"Event issue is trading flat.")]
    IssueTradingFlat = IssuerStatusCode.IssueTradingFlat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a late announcement with elections.
    /// Encoded/decoded by serializers as &quot;LAWE&quot;.
    /// </summary>
    [EnumMember(Value = "LAWE")]
    [IsoId("_1s2rFjL3EeKU9IrkkToqcw_-395760845")]
    [Description(@"Event is a late announcement with elections.")]
    LateAnnouncementWithElections = IssuerStatusCode.LateAnnouncementWithElections, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a liquidation.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_1s2rFzL3EeKU9IrkkToqcw_-509599911")]
    [Description(@"Event is a liquidation.")]
    Liquidation = IssuerStatusCode.Liquidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event proceeds will be paid upon receipt of funds.
    /// Encoded/decoded by serializers as &quot;PURF&quot;.
    /// </summary>
    [EnumMember(Value = "PURF")]
    [IsoId("_1s_1ADL3EeKU9IrkkToqcw_365004308")]
    [Description(@"Event proceeds will be paid upon receipt of funds.")]
    PaidUponrReceiptOfFunds = IssuerStatusCode.PaidUponrReceiptOfFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event processed are pending conversion of funds.
    /// Encoded/decoded by serializers as &quot;PCOF&quot;.
    /// </summary>
    [EnumMember(Value = "PCOF")]
    [IsoId("_1s_1ATL3EeKU9IrkkToqcw_1582093987")]
    [Description(@"Event processed are pending conversion of funds.")]
    PendingConversionOfFunds = IssuerStatusCode.PendingConversionOfFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is pending election dividend services elections.
    /// Encoded/decoded by serializers as &quot;PELE&quot;.
    /// </summary>
    [EnumMember(Value = "PELE")]
    [IsoId("_1s_1AjL3EeKU9IrkkToqcw_1468254921")]
    [Description(@"Event is pending election dividend services elections.")]
    PendingEDSElections = IssuerStatusCode.PendingEDSElections, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is pending SEC (Securities and Exchange Commission approval.
    /// Encoded/decoded by serializers as &quot;PSEC&quot;.
    /// </summary>
    [EnumMember(Value = "PSEC")]
    [IsoId("_1s_1AzL3EeKU9IrkkToqcw_-110086210")]
    [Description(@"Event is pending SEC (Securities and Exchange Commission approval.")]
    PendingSECApproval = IssuerStatusCode.PendingSECApproval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is pending SEC (Securities and Exchange Commission and shareholders approval.
    /// Encoded/decoded by serializers as &quot;PSHS&quot;.
    /// </summary>
    [EnumMember(Value = "PSHS")]
    [IsoId("_1s_1BDL3EeKU9IrkkToqcw_344001059")]
    [Description(
        @"Event is pending SEC (Securities and Exchange Commission and shareholders approval."
    )]
    PendingShareholderAndSECApproval = IssuerStatusCode.PendingShareholderAndSECApproval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is pending shareholder approval.
    /// Encoded/decoded by serializers as &quot;PSHA&quot;.
    /// </summary>
    [EnumMember(Value = "PSHA")]
    [IsoId("_1s_1BTL3EeKU9IrkkToqcw_230161993")]
    [Description(@"Event is pending shareholder approval.")]
    PendingShareholderApproval = IssuerStatusCode.PendingShareholderApproval, // same ordinal as derivation source for type conversions
}
