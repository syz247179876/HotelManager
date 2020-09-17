using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.QRCode.Codec;

namespace 天秀酒店管理系统
{
    class QR
    {
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="address"></param>
        /// <param name="size"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public static Image QrCodeBitmap(string address, int size, int version)
        {
            QRCodeEncoder qRCodeEncoder = new QRCodeEncoder
            {
                QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE,  //字节编码
                QRCodeScale = size   //二维码大小
            }; //生成设置编码的实例
            qRCodeEncoder.QRCodeScale = version; //版本
            qRCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;  //设置错误校验
            Image img = qRCodeEncoder.Encode(address);
            return img;

        }
    }
}
