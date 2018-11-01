using System;

namespace RsDictionary
{
    /// <summary>
    ///  This class is used to create a simplified general Dictionary object of value pairs for use. 
    ///  </summary>
    using System;
    using System.Collections.Generic;

    public class RsDictionary
    {
        // Last error message
        private string _LastError = "";
        // Internal dictionary
        private Dictionary<string, string> _dict = new Dictionary<string, string>();

        /// <summary>
        ///  Get last error
        ///  </summary>
        ///  <returns></returns>
        public string GetLastError()
        {
            return _LastError;
        }
        /// <summary>
        ///  Get the Dictionary object for use outside this class.
        ///  </summary>
        ///  <returns>Object of Dictionary(Of String,String)</returns>
        public Dictionary<string, string> GetDictionary()
        {
            return _dict;
        }

        /// <summary>
        ///  Add key pair to internal Dictionary items if not found.
        ///  </summary>
        ///  <param name="strKey">Key value</param>
        ///  <param name="strValue">Data value</param>
        ///  <returns>True=Key added. False=Key not added.</returns>
        public bool AddKey(string strKey, string strValue)
        {
            try
            {
                _LastError = "";

                // Check for key before adding
                if (ContainsKey(strKey))
                {
                    _LastError = string.Format("Dictionary key {0} already exists.", strKey);
                    return false;
                }
                else
                {
                    // Add the new key value 
                    _dict.Add(strKey, strValue);
                    return true;
                }
            }
            catch (Exception ex)
            {
                _LastError = ex.Message;
                return false;
            }
        }
        /// <summary>
        ///  Update key pair value if it exists in Dictionary already.
        ///  </summary>
        ///  <param name="strKey">Key value</param>
        ///  <param name="strValue">Data value</param>
        ///  <returns>True=Key updated. False=Key not updates.</returns>
        public bool UpdateKey(string strKey, string strValue)
        {
            try
            {
                _LastError = "";

                // Check for key before updating
                if (ContainsKey(strKey))
                {
                    _dict[strKey] = strValue;
                    return true;
                }
                else
                {
                    _LastError = string.Format("Dictionary key {0} not found.", strKey);
                    return false;
                }
            }
            catch (Exception ex)
            {
                _LastError = ex.Message;
                return false;
            }
        }
        /// <summary>
        ///  Remove key pair value if it exists already.
        ///  </summary>
        ///  <param name="strKey">Key value</param>
        ///  <returns>True=Key removed. False=Key not removed.</returns>
        public bool RemoveKey(string strKey)
        {
            try
            {
                _LastError = "";

                // Check for key before removing
                if (ContainsKey(strKey))
                {
                    _dict.Remove(strKey);
                    return true;
                }
                else
                {
                    _LastError = string.Format("Dictionary key {0} not found.", strKey);
                    return false;
                }
            }
            catch (Exception ex)
            {
                _LastError = ex.Message;
                return false;
            }
        }

        /// <summary>
        ///  Get internal dictionary item as String value or return blanks if key not found.
        ///  </summary>
        ///  <param name="strKey">Key value</param>
        ///  <returns>String value for selected key or blanks.</returns>
        public string GetItemAsString(string strKey)
        {
            try
            {
                _LastError = "";
                if (_dict.ContainsKey(strKey))
                    return _dict[strKey];
                else
                    throw new Exception(string.Format("Dictionary key {0} not found.", strKey));
            }
            catch (Exception ex)
            {
                _LastError = ex.Message;
                return "";
            }
        }
        /// <summary>
        ///  Get internal dictionary item as String value or return blanks if key not found.
        ///  </summary>
        ///  <param name="strKey">Key value</param>
        ///  <returns>Boolean value for selected key value or False.</returns>
        public bool GetItemAsBoolean(string strKey)
        {
            try
            {
                _LastError = "";
                if (_dict.ContainsKey(strKey))
                    return Convert.ToBoolean(_dict[strKey]);
                else
                    throw new Exception(string.Format("Dictionary key {0} not found.", strKey));
            }
            catch (Exception ex)
            {
                _LastError = ex.Message;
                return false;
            }
        }
        /// <summary>
        ///  Get internal dictionary item as Integer value or return 0 if key not found.
        ///  </summary>
        ///  <param name="strKey">Key value</param>
        ///  <returns>Integer value for selected key value or 0</returns>
        public int GetItemAsInteger(string strKey)
        {
            try
            {
                _LastError = "";
                if (_dict.ContainsKey(strKey))
                    return Convert.ToInt32(_dict[strKey]);
                else
                    throw new Exception(string.Format("Dictionary key {0} not found.", strKey));
            }
            catch (Exception ex)
            {
                _LastError = ex.Message;
                return 0;
            }
        }
        /// <summary>
        ///  Get internal dictionary item as Integer value or return 0 if key not found.
        ///  </summary>
        ///  <param name="strKey">Key value</param>
        ///  <returns>Double value for selected key value or 0</returns>
        public double GetItemAsDouble(string strKey)
        {
            try
            {
                _LastError = "";
                if (_dict.ContainsKey(strKey))
                    return Convert.ToDouble(_dict[strKey]);
                else
                    throw new Exception(string.Format("Dictionary key {0} not found.", strKey));
            }
            catch (Exception ex)
            {
                _LastError = ex.Message;
                return 0;
            }
        }
        /// <summary>
        ///  Check internal dictionary items to see if selected key is in the Dictionary
        ///  </summary>
        ///  <param name="strKey">Key value</param>
        ///  <returns>True=Key exist. False=Key not found.</returns>
        public bool ContainsKey(string strKey)
        {
            try
            {
                _LastError = "";
                if (_dict.ContainsKey(strKey))
                {
                    _LastError = string.Format("Dictionary key {0} exists.", strKey);
                    return true;
                }
                else
                {
                    _LastError = string.Format("Dictionary key {0} does not exist.", strKey);
                    return false;
                }
            }
            catch (Exception ex)
            {
                _LastError = ex.Message;
                return false;
            }
        }
        /// <summary>
        ///  Check internal dictionary items to see if selected value is in the Dictionary
        ///  </summary>
        ///  <param name="strValue">Value</param>
        ///  <returns>True=Value exists. False=Value not found.</returns>
        public bool ContainsValue(string strValue)
        {
            try
            {
                _LastError = "";
                return _dict.ContainsValue(strValue);
            }
            catch (Exception ex)
            {
                _LastError = ex.Message;
                return false;
            }
        }
        /// <summary>
        ///  Initialize or re-initialize the internal dictionary. Initial dictionary object is instantiated at class creation.
        ///  </summary>
        ///  <returns>True=Success,False=Error</returns>
        public bool Initialize()
        {
            try
            {
                _LastError = "";
                _dict = new Dictionary<string, string>();
                return true;
            }
            catch (Exception ex)
            {
                _LastError = ex.Message;
                return false;
            }
        }

        /// <summary>
        ///  Clear the internal dictionary. 
        ///  </summary>
        ///  <returns>True=Success,False=Error</returns>
        public bool Clear()
        {
            try
            {
                _LastError = "";
                _dict.Clear();
                return true;
            }
            catch (Exception ex)
            {
                _LastError = ex.Message;
                return false;
            }
        }
    }

}
