// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the party within a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kpxjk-5NEeCisYr99QEiWA_-1377825526")]
[Description(@"Specifies the type of the party within a system.")]
[Derivations(typeof(SystemPartyType1Code))]
public enum SystemPartyTypeCode
{
    /// <summary>
    /// Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.
    /// Encoded/decoded by serializers as &quot;CSDY&quot;.
    /// </summary>
    [EnumMember(Value = "CSDY")]
    [IsoId("_kpxjlO5NEeCisYr99QEiWA_-1491664592")]
    [Description(
        @"Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records."
    )]
    CentralSecuritiesDepository,

    /// <summary>
    /// As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy.
    /// Encoded/decoded by serializers as &quot;NCBK&quot;.
    /// </summary>
    [EnumMember(Value = "NCBK")]
    [IsoId("_kp6tgO5NEeCisYr99QEiWA_1628111679")]
    [Description(
        @"As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy."
    )]
    NationalCentralBank,

    /// <summary>
    /// National central bank or a private bank used to settle the cash leg of securities settlements: it provides the cash account to support the settlement of the securities transactions of another financial institution in central bank money (CeBM).
    /// Encoded/decoded by serializers as &quot;PMBK&quot;.
    /// </summary>
    [EnumMember(Value = "PMBK")]
    [IsoId("_kp6tge5NEeCisYr99QEiWA_-1366879028")]
    [Description(
        @"National central bank or a private bank used to settle the cash leg of securities settlements: it provides the cash account to support the settlement of the securities transactions of another financial institution in central bank money (CeBM)."
    )]
    PaymentBank,

    /// <summary>
    /// Participant of a central securities depositary defined within the system, for which the account holder is the central securities depository.
    /// Encoded/decoded by serializers as &quot;CSDP&quot;.
    /// </summary>
    [EnumMember(Value = "CSDP")]
    [IsoId("_kp6tgu5NEeCisYr99QEiWA_-166734643")]
    [Description(
        @"Participant of a central securities depositary defined within the system, for which the account holder is the central securities depository."
    )]
    CentralSecuritiesDepositoryParticipant,

    /// <summary>
    /// Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.
    /// The infrastructure is external to the system executing the instruction.
    /// Encoded/decoded by serializers as &quot;ECSD&quot;.
    /// </summary>
    [EnumMember(Value = "ECSD")]
    [IsoId("_kp6tg-5NEeCisYr99QEiWA_1619669745")]
    [Description(
        @"Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.|The infrastructure is external to the system executing the instruction."
    )]
    ExternalCentralSecuritiesDepository,
}
