﻿using System;
using System.ComponentModel.DataAnnotations;

namespace web.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "กรุณาระบุหมายเลขบัตรยูเมะพลัสค่ะ")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "หมายเลขบัตรยูเมะพลัสไม่ถูกต้อง กรุณาระบุ 16 หลักค่ะ")]
        public string txt_CardNo { get; set; }

        [Required(ErrorMessage = "กรุณาระบุหมายเลขบัตรประชาชนค่ะ")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "หมายเลขบัตรประชาชนไม่ถูกต้อง กรุณาระบุ 13 หลักค่ะ")]
        public string txt_CardID { get; set; }

        [Required(ErrorMessage = "กรุณาระบุวันเดือนปีเกิดค่ะ")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "กรุณากรอกข้อมูล วัน/เดือน/ปี พ.ศ.")]
        public string txt_BirthDate { get; set; }

        public string txt_Mobile { get; set; }
    }
}
