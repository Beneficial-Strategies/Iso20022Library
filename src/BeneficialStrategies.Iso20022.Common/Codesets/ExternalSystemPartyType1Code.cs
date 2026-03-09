// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the system party type, as published in an external system party type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_u1-g4FhOEeih3fUfzR38Ig")]
[Description(@"Specifies the system party type, as published in an external system party type code set.")]
[DerivedFrom(typeof(ExternalSystemPartyTypeCode))]
public enum ExternalSystemPartyType1Code
{
    /// <summary>
    /// System in which payments and/or financial instruments are exchanged and/or cleared or recorded, while the ensuing monetary obligations are settled in another system, typically an RTGS system.
    /// Encoded/decoded by serializers as &quot;ANSY&quot;.
    /// </summary>
    [EnumMember(Value = "ANSY")]
    [IsoId("")]
    [Description(@"System in which payments and/or financial instruments are exchanged and/or cleared or recorded, while the ensuing monetary obligations are settled in another system, typically an RTGS system.")]
    AncillarySystem = ExternalSystemPartyTypeCode.AncillarySystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal entity or, as the case may be, an individual having a contractual relationship with the CSD for the processing of its securities settlement-related activities in T2S.
    /// Encoded/decoded by serializers as &quot;CSDP&quot;.
    /// </summary>
    [EnumMember(Value = "CSDP")]
    [IsoId("")]
    [Description(@"Legal entity or, as the case may be, an individual having a contractual relationship with the CSD for the processing of its securities settlement-related activities in T2S.")]
    CentralSecuritiesDepositoryParticipant = ExternalSystemPartyTypeCode.CentralSecuritiesDepositoryParticipant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Infrastructure that holds or controls the holding of physical or dematerialized financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralized transfer of ownership of such securities by entries on its books and records.
    /// Encoded/decoded by serializers as &quot;CSDY&quot;.
    /// </summary>
    [EnumMember(Value = "CSDY")]
    [IsoId("")]
    [Description(@"Infrastructure that holds or controls the holding of physical or dematerialized financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralized transfer of ownership of such securities by entries on its books and records.")]
    CentralSecuritiesDepository = ExternalSystemPartyTypeCode.CentralSecuritiesDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Infrastructure that holds or controls the holding of physical or dematerialized financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralized transfer of ownership of such securities by entries on its books and records. The infrastructure is external to the system executing the instruction.
    /// Encoded/decoded by serializers as &quot;ECSD&quot;.
    /// </summary>
    [EnumMember(Value = "ECSD")]
    [IsoId("")]
    [Description(@"Infrastructure that holds or controls the holding of physical or dematerialized financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralized transfer of ownership of such securities by entries on its books and records. The infrastructure is external to the system executing the instruction.")]
    ExternalCentralSecuritiesDepository = ExternalSystemPartyTypeCode.ExternalCentralSecuritiesDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy.
    /// Encoded/decoded by serializers as &quot;NCBK&quot;.
    /// </summary>
    [EnumMember(Value = "NCBK")]
    [IsoId("")]
    [Description(@"As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy.")]
    NationalCentralBank = ExternalSystemPartyTypeCode.NationalCentralBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commercial bank used to effect money settlements.
    /// Encoded/decoded by serializers as &quot;PMBK&quot;.
    /// </summary>
    [EnumMember(Value = "PMBK")]
    [IsoId("")]
    [Description(@"Commercial bank used to effect money settlements.")]
    PaymentBank = ExternalSystemPartyTypeCode.PaymentBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that owns an account in the system, but only supports a limited range of available use cases in interaction with counterparties.
    /// Encoded/decoded by serializers as &quot;STPR&quot;.
    /// </summary>
    [EnumMember(Value = "STPR")]
    [IsoId("")]
    [Description(@"Party that owns an account in the system, but only supports a limited range of available use cases in interaction with counterparties.")]
    StandardParticipantRestricted = ExternalSystemPartyTypeCode.StandardParticipantRestricted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that owns an account in the system and can interact with the system or counterparties using all use cases available to standard participants.
    /// Encoded/decoded by serializers as &quot;STPU&quot;.
    /// </summary>
    [EnumMember(Value = "STPU")]
    [IsoId("")]
    [Description(@"Party that owns an account in the system and can interact with the system or counterparties using all use cases available to standard participants.")]
    StandardParticipantUnrestricted = ExternalSystemPartyTypeCode.StandardParticipantUnrestricted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that defines the eligibility criteria of the system and is responsible for monitoring, controlling and, if necessary, operating the system. All authorizations are available to the system manager when interacting with the system.
    /// Encoded/decoded by serializers as &quot;SYMG&quot;.
    /// </summary>
    [EnumMember(Value = "SYMG")]
    [IsoId("")]
    [Description(@"Party that defines the eligibility criteria of the system and is responsible for monitoring, controlling and, if necessary, operating the system. All authorizations are available to the system manager when interacting with the system.")]
    SystemManager = ExternalSystemPartyTypeCode.SystemManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that operates the system on behalf of the system manager (if different from the system manager) and is provided with specific authorizations by the system manager for this purpose.
    /// Encoded/decoded by serializers as &quot;SYOP&quot;.
    /// </summary>
    [EnumMember(Value = "SYOP")]
    [IsoId("")]
    [Description(@"Party that operates the system on behalf of the system manager (if different from the system manager) and is provided with specific authorizations by the system manager for this purpose.")]
    SystemOperator = ExternalSystemPartyTypeCode.SystemOperator, // same ordinal as derivation source for type conversions

}
