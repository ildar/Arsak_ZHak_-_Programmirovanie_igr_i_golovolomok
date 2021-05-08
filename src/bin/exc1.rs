// Exercise 1 (p.13 of the book)

const SAMPLES_NUM: u32 = 5000;
const INTERVALS_NUM: usize = 50;
const B_INIT_DEFAULT: f32 = 0.123;

use arsak_zhak_programmirovanie_igr_i_golovolomok::*;
use std::env;
use std::str::FromStr;

fn main() {
    let args: Vec<String> = env::args().collect();
    let mut b = if args.len() == 1 {
        B_INIT_DEFAULT
    } else {
        match f32::from_str(&args[1]) {
            Ok(res) => res,
            _ => B_INIT_DEFAULT,
        }
    };
    let mut intervals = [0; INTERVALS_NUM];

    for _ in 0..SAMPLES_NUM {
        b = random(b);
        intervals[(b * (INTERVALS_NUM as f32)).trunc() as usize] += 1;
    }
    println!("is it even?");
    for i in 0..INTERVALS_NUM {
        println!("{}", intervals[i as usize]);
    }
}
