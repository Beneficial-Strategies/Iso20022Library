// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Hardware capabilities of the Sale Terminal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yEJFENtrEeiXqq0XHEoNUA")]
[Description(@"Hardware capabilities of the Sale Terminal.")]
[Derivations(typeof(SaleCapabilities2Code),typeof(SaleCapabilities1Code))]
public enum SaleCapabilitiesCode
{
    /// <summary>
    /// To display to the Cashier a new state on which the POI is entering. 	For instance, during a payment, the POI could display to the Cashier that POI request an authorisation to the host acquirer.
    /// Encoded/decoded by serializers as &quot;CHST&quot;.
    /// </summary>
    [EnumMember(Value = "CHST")]
    [IsoId("_1aQFQNtrEeiXqq0XHEoNUA")]
    [Description(@"To display to the Cashier a new state on which the POI is entering. 	For instance, during a payment, the POI could display to the Cashier that POI request an authorisation to the host acquirer.")]
    CashierStatus,
    
    /// <summary>
    /// To display to the Cashier information related to an error situation occurring on the POI.
    /// Encoded/decoded by serializers as &quot;CHER&quot;.
    /// </summary>
    [EnumMember(Value = "CHER")]
    [IsoId("_5kc00NtrEeiXqq0XHEoNUA")]
    [Description(@"To display to the Cashier information related to an error situation occurring on the POI.")]
    CashierError,
    
    /// <summary>
    /// Standard Cashier display interface (to ask question, or to show information). 
    /// Encoded/decoded by serializers as &quot;CHDI&quot;.
    /// </summary>
    [EnumMember(Value = "CHDI")]
    [IsoId("_8rCLQNtrEeiXqq0XHEoNUA")]
    [Description(@"Standard Cashier display interface (to ask question, or to show information). ")]
    CashierDisplay,
    
    /// <summary>
    /// Information displayed on the Cardholder POI interface, replicated on the Cashier interface.
    /// Encoded/decoded by serializers as &quot;POIR&quot;.
    /// </summary>
    [EnumMember(Value = "POIR")]
    [IsoId("__dj9QNtrEeiXqq0XHEoNUA")]
    [Description(@"Information displayed on the Cardholder POI interface, replicated on the Cashier interface.")]
    POIReplication,
    
    /// <summary>
    /// Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element). The output device attached to this input device is the CashierDisplay device.
    /// Encoded/decoded by serializers as &quot;CHIN&quot;.
    /// </summary>
    [EnumMember(Value = "CHIN")]
    [IsoId("_CnlpQNtsEeiXqq0XHEoNUA")]
    [Description(@"Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element). The output device attached to this input device is the CashierDisplay device.")]
    CashierInput,
    
    /// <summary>
    /// Input of the Cardholder POI interface which can be entered by the Cashier to assist the Customer.
    /// Encoded/decoded by serializers as &quot;CUAS&quot;.
    /// </summary>
    [EnumMember(Value = "CUAS")]
    [IsoId("_HNoAQNtsEeiXqq0XHEoNUA")]
    [Description(@"Input of the Cardholder POI interface which can be entered by the Cashier to assist the Customer.")]
    CustomerAssistance,
    
    /// <summary>
    /// Standard Customer display interface used by the POI System to ask question, or to show information to the Customer inside a Service dialogue.
    /// Encoded/decoded by serializers as &quot;CUDI&quot;.
    /// </summary>
    [EnumMember(Value = "CUDI")]
    [IsoId("_KU_Z0NtsEeiXqq0XHEoNUA")]
    [Description(@"Standard Customer display interface used by the POI System to ask question, or to show information to the Customer inside a Service dialogue.")]
    CustomerDisplay,
    
    /// <summary>
    /// To display to the Customer information is related to an error situation occurring on the Sale Terminal during a Sale transaction.
    /// Encoded/decoded by serializers as &quot;CUER&quot;.
    /// </summary>
    [EnumMember(Value = "CUER")]
    [IsoId("_NNsFQNtsEeiXqq0XHEoNUA")]
    [Description(@"To display to the Customer information is related to an error situation occurring on the Sale Terminal during a Sale transaction.")]
    CustomerError,
    
    /// <summary>
    /// Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element).
    /// Encoded/decoded by serializers as &quot;CUIN&quot;.
    /// </summary>
    [EnumMember(Value = "CUIN")]
    [IsoId("_QgQpQNtsEeiXqq0XHEoNUA")]
    [Description(@"Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element).")]
    CustomerInput,
    
    /// <summary>
    /// Printer for the Payment receipt.
    /// Encoded/decoded by serializers as &quot;PRRP&quot;.
    /// </summary>
    [EnumMember(Value = "PRRP")]
    [IsoId("_UHz-wNtsEeiXqq0XHEoNUA")]
    [Description(@"Printer for the Payment receipt.")]
    PrinterReceipt,
    
    /// <summary>
    /// When the POI System wants to print specific document (check, dynamic currency conversion ...).
    /// Encoded/decoded by serializers as &quot;PRDC&quot;.
    /// </summary>
    [EnumMember(Value = "PRDC")]
    [IsoId("_WQrvwNtsEeiXqq0XHEoNUA")]
    [Description(@"When the POI System wants to print specific document (check, dynamic currency conversion ...).")]
    PrinterDocument,
    
    /// <summary>
    /// Coupons, voucher or special ticket generated by the POI and to be printed. 
    /// Encoded/decoded by serializers as &quot;PRVC&quot;.
    /// </summary>
    [EnumMember(Value = "PRVC")]
    [IsoId("_ZTVBYNtsEeiXqq0XHEoNUA")]
    [Description(@"Coupons, voucher or special ticket generated by the POI and to be printed. ")]
    PrinterVoucher,
    
}
