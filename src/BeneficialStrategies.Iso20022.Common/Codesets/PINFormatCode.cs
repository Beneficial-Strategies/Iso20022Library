// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// PIN (Personal Identification Number) format used to encrypt the PIN block.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVCuCwEcEeCQm6a_G2yO_w_1593903666")]
[Description(@"PIN (Personal Identification Number) format used to encrypt the PIN block.")]
[Derivations(typeof(PINFormat1Code),typeof(PINFormat2Code),typeof(PINFormat3Code),typeof(PINFormat4Code))]
public enum PINFormatCode
{
    /// <summary>
    /// PIN diversified with the card account number, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO0&quot;.
    /// </summary>
    [EnumMember(Value = "ISO0")]
    [IsoId("_TVCuDAEcEeCQm6a_G2yO_w_-410325828")]
    [Description(@"PIN diversified with the card account number, conforming to the standard ISO 9564-2.")]
    ISO0,
    
    /// <summary>
    /// PIN completed with random padding characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO1&quot;.
    /// </summary>
    [EnumMember(Value = "ISO1")]
    [IsoId("_TVCuDQEcEeCQm6a_G2yO_w_-354675290")]
    [Description(@"PIN completed with random padding characters, conforming to the standard ISO 9564-2.")]
    ISO1,
    
    /// <summary>
    /// PIN without diversification characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO2&quot;.
    /// </summary>
    [EnumMember(Value = "ISO2")]
    [IsoId("_TVCuDgEcEeCQm6a_G2yO_w_-365774067")]
    [Description(@"PIN without diversification characters, conforming to the standard ISO 9564-2.")]
    ISO2,
    
    /// <summary>
    /// PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO3&quot;.
    /// </summary>
    [EnumMember(Value = "ISO3")]
    [IsoId("_TVCuDwEcEeCQm6a_G2yO_w_-453395369")]
    [Description(@"PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2.")]
    ISO3,
    
    /// <summary>
    /// PIN format used with AES encryption, conforming to the new ISO SC2 format.
    /// Encoded/decoded by serializers as &quot;ISO4&quot;.
    /// </summary>
    [EnumMember(Value = "ISO4")]
    [IsoId("_sPjUEL4pEeKkGaJ0UrThyA_441850847")]
    [Description(@"PIN format used with AES encryption, conforming to the new ISO SC2 format.")]
    ISO4,
    
    /// <summary>
    /// Alternative PIN format used with AES encryption, conforming to the new ISO SC2 format.
    /// Encoded/decoded by serializers as &quot;ISO5&quot;.
    /// </summary>
    [EnumMember(Value = "ISO5")]
    [IsoId("_GvGPgC_tEeO4w-IWHJMI9g")]
    [Description(@"Alternative PIN format used with AES encryption, conforming to the new ISO SC2 format.")]
    ISO5,
    
    /// <summary>
    /// ANSI 0 PIN block format.
    /// Encoded/decoded by serializers as &quot;ANSI&quot;.
    /// </summary>
    [EnumMember(Value = "ANSI")]
    [IsoId("_05VhkIobEeSirOZJBRz_nA")]
    [Description(@"ANSI 0 PIN block format.")]
    ANSI0,
    
    /// <summary>
    /// Italian Bancomat PIN block format.
    /// Encoded/decoded by serializers as &quot;BNCM&quot;.
    /// </summary>
    [EnumMember(Value = "BNCM")]
    [IsoId("_3ye48IobEeSirOZJBRz_nA")]
    [Description(@"Italian Bancomat PIN block format.")]
    Bancomat,
    
    /// <summary>
    /// Banksys PIN block format.
    /// Encoded/decoded by serializers as &quot;BKSY&quot;.
    /// </summary>
    [EnumMember(Value = "BKSY")]
    [IsoId("_6Cw5gIobEeSirOZJBRz_nA")]
    [Description(@"Banksys PIN block format.")]
    Banksys,
    
    /// <summary>
    /// Diebold PIN block format.
    /// Encoded/decoded by serializers as &quot;DBLD&quot;.
    /// </summary>
    [EnumMember(Value = "DBLD")]
    [IsoId("_9vLg4IobEeSirOZJBRz_nA")]
    [Description(@"Diebold PIN block format.")]
    Diebold,
    
    /// <summary>
    /// Diebold CO PIN block format.
    /// Encoded/decoded by serializers as &quot;DBLC&quot;.
    /// </summary>
    [EnumMember(Value = "DBLC")]
    [IsoId("_AibEkIocEeSirOZJBRz_nA")]
    [Description(@"Diebold CO PIN block format.")]
    DieboldCO,
    
    /// <summary>
    /// ECI2 PIN block format.
    /// Encoded/decoded by serializers as &quot;ECI2&quot;.
    /// </summary>
    [EnumMember(Value = "ECI2")]
    [IsoId("_DghNYIocEeSirOZJBRz_nA")]
    [Description(@"ECI2 PIN block format.")]
    ECI2,
    
    /// <summary>
    /// ECI3 PIN block format.
    /// Encoded/decoded by serializers as &quot;ECI3&quot;.
    /// </summary>
    [EnumMember(Value = "ECI3")]
    [IsoId("_IsgKEIocEeSirOZJBRz_nA")]
    [Description(@"ECI3 PIN block format.")]
    ECI3,
    
    /// <summary>
    /// EMV ISO2 PIN block format encrypted with the EMV RSA cryptographic key for the PIN.
    /// Encoded/decoded by serializers as &quot;EMVS&quot;.
    /// </summary>
    [EnumMember(Value = "EMVS")]
    [IsoId("_Lbff4IocEeSirOZJBRz_nA")]
    [Description(@"EMV ISO2 PIN block format encrypted with the EMV RSA cryptographic key for the PIN.")]
    EMVRSA,
    
    /// <summary>
    /// IBM 3624 PIN block format.
    /// Encoded/decoded by serializers as &quot;IBM3&quot;.
    /// </summary>
    [EnumMember(Value = "IBM3")]
    [IsoId("_PZV1gIocEeSirOZJBRz_nA")]
    [Description(@"IBM 3624 PIN block format.")]
    IBM3624,
    
    /// <summary>
    /// VISA2 PIN block format.
    /// Encoded/decoded by serializers as &quot;VIS2&quot;.
    /// </summary>
    [EnumMember(Value = "VIS2")]
    [IsoId("_R_qXgIocEeSirOZJBRz_nA")]
    [Description(@"VISA2 PIN block format.")]
    VISA2,
    
    /// <summary>
    /// VISA3 PIN block format.
    /// Encoded/decoded by serializers as &quot;VIS3&quot;.
    /// </summary>
    [EnumMember(Value = "VIS3")]
    [IsoId("_UlIk8IocEeSirOZJBRz_nA")]
    [Description(@"VISA3 PIN block format.")]
    VISA3,
    
}
