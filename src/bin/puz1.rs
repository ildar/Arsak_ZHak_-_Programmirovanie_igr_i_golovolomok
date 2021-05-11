// Puzzle 1 (p.31 of the book)

const TOP_EDGE: u32 = 10000;

use arsak_zhak_programmirovanie_igr_i_golovolomok::*;
use std::env;
use std::str::FromStr;

// Run as puz1 [initial_value]
fn main() {
    let args: Vec<String> = env::args().collect();
    let mut p = if args.len() == 1 {
        0
    } else {
        match u32::from_str(&args[1]) {
            Ok(res) => res,
            _ => 0,
        }
    };
    let fn_random = |seed:u32| {
        (TOP_EDGE as f32 * random(seed as f32 / TOP_EDGE as f32)).trunc() as u32
    };

    for _ in 0..TOP_EDGE { p = fn_random(p); }
    let fix_p = p;
    let mut period = 1;
    loop {
        p = fn_random(p);
        if p == fix_p { break; } else { period += 1; };
    }
    println!("Period found == {}", period);
    for _ in 0..=period { p = fn_random(p); print!("{} ", p) }
}
