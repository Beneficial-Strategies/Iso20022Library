// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the party within a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kp6thO5NEeCisYr99QEiWA_-1109986721")]
[Description(@"Specifies the type of the party within a system.")]
[DerivedFrom(typeof(SystemPartyTypeCode))]
public enum SystemPartyType1Code
{
    /// <summary>
    /// Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.
    /// Encoded/decoded by serializers as &quot;CSDY&quot;.
    /// </summary>
    [EnumMember(Value = "CSDY")]
    [IsoId("_kqEegO5NEeCisYr99QEiWA_1337153248")]
    [Description(@"Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.")]
    CentralSecuritiesDepository = SystemPartyTypeCode.CentralSecuritiesDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy.
    /// Encoded/decoded by serializers as &quot;NCBK&quot;.
    /// </summary>
    [EnumMember(Value = "NCBK")]
    [IsoId("_kqEege5NEeCisYr99QEiWA_-1879793710")]
    [Description(@"As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy.")]
    NationalCentralBank = SystemPartyTypeCode.NationalCentralBank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National central bank or a private bank used to settle the cash leg of securities settlements: it provides the cash account to support the settlement of the securities transactions of another financial institution in central bank money (CeBM).
    /// Encoded/decoded by serializers as &quot;PMBK&quot;.
    /// </summary>
    [EnumMember(Value = "PMBK")]
    [IsoId("_kqEegu5NEeCisYr99QEiWA_1622437669")]
    [Description(@"National central bank or a private bank used to settle the cash leg of securities settlements: it provides the cash account to support the settlement of the securities transactions of another financial institution in central bank money (CeBM).")]
    PaymentBank = SystemPartyTypeCode.PaymentBank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant of a central securities depositary defined within the system, for which the account holder is the central securities depository.
    /// Encoded/decoded by serializers as &quot;CSDP&quot;.
    /// </summary>
    [EnumMember(Value = "CSDP")]
    [IsoId("_kqEeg-5NEeCisYr99QEiWA_-1911764474")]
    [Description(@"Participant of a central securities depositary defined within the system, for which the account holder is the central securities depository.")]
    CentralSecuritiesDepositoryParticipant = SystemPartyTypeCode.CentralSecuritiesDepositoryParticipant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.
    /// The infrastructure is external to the system executing the instruction.
    /// Encoded/decoded by serializers as &quot;ECSD&quot;.
    /// </summary>
    [EnumMember(Value = "ECSD")]
    [IsoId("_kqEehO5NEeCisYr99QEiWA_373245964")]
    [Description(@"Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.|The infrastructure is external to the system executing the instruction.")]
    ExternalCentralSecuritiesDepository = SystemPartyTypeCode.ExternalCentralSecuritiesDepository, // same ordinal as derivation source for type conversions
    
}
